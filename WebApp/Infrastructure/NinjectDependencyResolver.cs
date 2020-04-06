using Ninject;
using System;
using System.Collections.Generic;
using Domain.Interfaces;
using Repositories;
using Services;
using Services.Implementation;
using System.Web.Mvc;
using Services.FeedNews;
using Services.News;
using Services.Category;
using Services.Implementation.FeedNews;
using Services.Implementation.Category;
using Services.Implementation.News;

namespace WebApp.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
        private void AddBindings()
        {
            kernel.Bind(typeof(IBaseRepository<>)).To(typeof(BaseRepository<>));
            kernel.Bind(typeof(IBaseService<>)).To(typeof(BaseService<,>));
            kernel.Bind<INewsRepository>().To<NewsRepository>();
            kernel.Bind<IFeedNewsRepository>().To<FeedNewsRepository>();
            kernel.Bind<ICategoryRepository>().To<CategoryRepository>();
            kernel.Bind<IFeedNewsService>().To<FeedNewsService>();
            kernel.Bind<INewsService>().To<NewsService>();
            kernel.Bind<ICategoryService>().To<CategoryService>();
        }
    }
}