using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ProHealth.Droid.Helpers
{
    public class SearchDoctorModel
    {
        private char iconID;

        public char IconId
        {
            get { return iconID; }
            set { iconID = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

    }

    public class SearchDoctorInfo
    {
        private static List<SearchDoctorModel> AddCategories;
        public List<SearchDoctorModel> Categories;
        public int NumOfCategories
        {
            get { return Categories != null ? Categories.Count : 0; }
        }
        public List<SearchDoctorModel> MyReports
        {
            get { return MyReportsCategories.ToList<SearchDoctorModel>(); }
        }

        public static SearchDoctorModel[] MyReportsCategories =
        {
            new SearchDoctorModel {IconId='J',Count=00,Name="Dentist" },
            new SearchDoctorModel {IconId='K',Count=01,Name="Dermatologist" },
            new SearchDoctorModel {IconId='L',Count=05,Name="Gastroenterologist" },
            new SearchDoctorModel {IconId='M',Count=03,Name="ENT Specialist" },
            new SearchDoctorModel {IconId='N',Count=07,Name="Psyciatrist" },
            new SearchDoctorModel {IconId='S',Count=09,Name="Cardiologist" }
        };
        public SearchDoctorInfo()
        {
            var categories = new List<SearchDoctorModel>();
            categories.AddRange(MyReportsCategories);
            Categories = categories;
        }
        public SearchDoctorModel this[int i]
        {
            get { return Categories[i]; }
        }
    }
}
