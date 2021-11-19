using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace prs_server_net5 {
	public class Startup {
		public Startup(IConfiguration configuration) {
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services) {

			services.AddControllers();
#if MAC
			// TEST
#endif
			var connStrKey = "PrsDbContext";
			if(Environment.OSVersion.Platform != PlatformID.Win32NT) {
				connStrKey = $"{connStrKey}Mac";
            }

			services.AddDbContext<PrsDbContext>(x => {
				x.UseSqlServer(Configuration.GetConnectionString(connStrKey));
			});

			services.AddCors();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
			if (env.IsDevelopment()) {
				app.UseDeveloperExceptionPage();
			}

			app.UseCors(x => x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints => {
				endpoints.MapControllers();
			});
		}
	}
}
