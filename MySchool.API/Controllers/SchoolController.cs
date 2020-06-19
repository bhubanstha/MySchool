using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySchool.Data.Context;
using MySchool.Business.ViewModel;
using MySchool.Data.Interface;
using MySchool.Data.Entity;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace MySchool.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SchoolController : ControllerBase
    {

        private ICrud<School> schoolRepo;
        private MySchoolContext context;
        private readonly IMapper mapper;
        private readonly IHostingEnvironment environment;

        public SchoolController(MySchoolContext _context, ICrud<School> _schoolRepo, IMapper _mapper, IHostingEnvironment  _env)
        {
            this.schoolRepo = _schoolRepo;
            this.context = _context;
            this.mapper = _mapper;
            this.environment = _env;
        }

        [HttpGet]
        public async Task<IEnumerable<School>> Get()
        {
            return await schoolRepo.GetAll();
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<int> Save([FromForm] SchoolVM school)
        {
            if (ModelState.IsValid)
            {
                var uploads = Path.Combine(environment.ContentRootPath, "Files", "Logo");
                var filePath = Path.Combine(uploads, school.Logo.FileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await school.Logo.CopyToAsync(fileStream);
                }

                School sch = mapper.Map<School>(school);
                int records = await schoolRepo.Create(sch);
                return records + 20;
            }
            return 0;
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<int> TestFileUpload([FromForm(Name = "abc")] List<IFormFile> files)
        {
            int i = 0;
            if(Request.Form.Files.Count>0)
            {
                i = 1;
                if(files != null && files.Count>0)
                {
                    i = 2;
                }
            }
            return i;
            //return (Request.Form.Files.Count>0) ? 1:0;
            
        }
    }
}