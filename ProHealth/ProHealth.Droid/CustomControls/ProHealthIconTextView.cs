using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.Runtime;
using Android.Util;
using Android.Widget;
using ProHealth.Droid.Helpers;

namespace ProHealth.Droid.CustomControls
{
    public class ProHealthIconTextView : TextView
    {
        public ProHealthIconTextView(Context context) :
            base(context)
        {
        }

        protected ProHealthIconTextView(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }


        public ProHealthIconTextView(Context context, IAttributeSet attrs) :
            base(context, attrs)
        {
            this.Initialize(context, attrs);
        }

        public ProHealthIconTextView(Context context, IAttributeSet attrs, int defStyle) :
            base(context, attrs, defStyle)
        {
            this.Initialize(context, attrs);
        }

        private void Initialize(Context context, IAttributeSet attrs)
        {
            try
            {
                var font = this.ObtainTypeface(context);
                this.SetTypeface(font, TypefaceStyle.Normal);
            }
            catch (Exception)
            {

            }
        }

        private Typeface ObtainTypeface(Context context)
        {
            try
            {
                var typeface = Typeface.CreateFromAsset(context.Assets, Constants.ProHealthIconFontPath);
                return typeface;
            }
            catch (Exception ex)
            {

            }

            return null;
        }
    }
}