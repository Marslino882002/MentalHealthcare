using MentalHealthcare.Domain.Entities;
using MentalHealthcare.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalHealthcare.Infrastructure.implementations
{
    public interface AdminRepository<T> : IAdminRepository<T> where T : Admin
    {

     public interface IAdminRepository<T>  where T : Admin
    {

        #region Signature_CRUD_Operation at Dashboad


        Task<IEnumerable<User?>> GetAllAsync();
        Task<User?> GetByIdAsync(int id);
        Task<User?> GetByUserName(string userNames);
         int DeleteUser(User users);



        Task AddVideos(Video videos); //Upload
       Task UpdateVideos(Video videos);
        public int DeleteVideos(Video videos);


        Task AddArticle(Article articles); //Upload
        Task UpdateArticle(Article articles);
        public int DeleteArticle(Article articles);


        Task AddMeditation(Meditation meditations); //Upload
       Task UpdateMeditation(Meditation meditations);
        public int DeleteMeditation(Meditation meditations);


        Task AddPodcast(Podcast podcasts); //Upload
        Task UpdatePodcast(Podcast podcasts);
        public int DeletePodcast(Podcast podcasts);



        Task AddCourses(Course courses);//Upload
       Task UpdateCourses(Course courses);
        public int DeleteCourses(Course courses);



        Task AddPdf(Pdf Pdf); //Upload
        public int DeletePdf(Pdf Pdfs);

        #endregion







    }






    }
}
