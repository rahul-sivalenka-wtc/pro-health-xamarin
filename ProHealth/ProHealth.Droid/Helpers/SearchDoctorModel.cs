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
        private int iconID;

        public int IconId
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
            new SearchDoctorModel {IconId=Resource.Drawable.heart,Count=00,Name="Dinesh" },
            new SearchDoctorModel {IconId=Resource.Drawable.heart,Count=01,Name="Rahul" },
            new SearchDoctorModel {IconId=Resource.Drawable.heart,Count=05,Name="veswanth" },
            new SearchDoctorModel {IconId=Resource.Drawable.heart,Count=03,Name="kiran" },
            new SearchDoctorModel {IconId=Resource.Drawable.heart,Count=07,Name="siva" },
            new SearchDoctorModel {IconId=Resource.Drawable.heart,Count=09,Name="Reddy" }
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
