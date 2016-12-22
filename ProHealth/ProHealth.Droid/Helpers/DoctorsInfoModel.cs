using System.Collections.Generic;
using System.Linq;

namespace ProHealth.Droid.Helpers
{
    public class DoctorsInfoModel
    {
        private int doctorImageId;

        public int DoctorImageId
        {
            get { return doctorImageId; }
            set { doctorImageId = value; }
        }
        private int doctorRating;

        public int DoctorRating
        {
            get { return doctorRating; }
            set { doctorRating = value; }
        }
        private string doctorName;

        public string DoctorName
        {
            get { return doctorName; }
            set { doctorName = value; }
        }
        private string expertIn;

        public string ExpertIn
        {
            get { return expertIn; }
            set { expertIn = value; }
        }
        private string specialization;

        public string Specialization
        {
            get { return specialization; }
            set { specialization = value; }
        }
        private int experience;

        public int Experience
        {
            get { return experience; }
            set { experience = value; }
        }
        private int doctorFee;

        public int DoctorFee
        {
            get { return doctorFee; }
            set { doctorFee = value; }
        }

    }

    public class DoctorsInformation
    {
        private static List<DoctorsInfoModel> AddCategories;
        public List<DoctorsInfoModel> DoctorsList;
        public int NumOfCategories
        {
            get { return DoctorsList != null ? DoctorsList.Count : 0; }
        }
        public List<DoctorsInfoModel> MyReports
        {
            get { return DoctorCategories.ToList<DoctorsInfoModel>(); }
        }

        public static DoctorsInfoModel[] DoctorCategories =
        {
            new DoctorsInfoModel {DoctorImageId=Resource.Drawable.Image_1,DoctorName="Dr.Shaw",DoctorRating=70,DoctorFee=500,Experience=5,ExpertIn="General physician/ family practitioner", Specialization="MBBS" },
            new DoctorsInfoModel {DoctorImageId=Resource.Drawable.Image_2,DoctorName="Dr.Prem",DoctorRating=50,DoctorFee=500,Experience=5,ExpertIn="Cardiologist", Specialization="MBBS" },
            new DoctorsInfoModel {DoctorImageId=Resource.Drawable.Image_3,DoctorName="Dr.Veswanth",DoctorRating=80,DoctorFee=500,Experience=5,ExpertIn="Pediatric cardiologist", Specialization="MBBS,FRCS" }
        };
        public DoctorsInformation()
        {
            var categories = new List<DoctorsInfoModel>();
            categories.AddRange(DoctorCategories);
            DoctorsList = categories;
        }
        public DoctorsInfoModel this[int i]
        {
            get { return DoctorsList[i]; }
        }
    }
}