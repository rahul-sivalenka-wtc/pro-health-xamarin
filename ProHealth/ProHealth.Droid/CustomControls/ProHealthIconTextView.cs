using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.Runtime;
using Android.Util;
using Android.Widget;
using ProHealth.Droid.Helpers;
using System;
using System.Collections.Generic;

namespace ProHealth.Droid.CustomControls
{
    public class ProHealthIconTextView : TextView
    {
        private const int ProHealthIcon = 0;

        private static readonly Dictionary<int, Typeface> Typefaces = new Dictionary<int, Typeface>(26);

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
                TypedArray values = context.ObtainStyledAttributes(attrs, Resource.Styleable.ProHealthIconTextView);

                int typefaceValue = values.GetInt(Resource.Styleable.ProHealthIconTextView_typeface, 0);
                values.Recycle();
                var font = this.ObtainTypeface(context, typefaceValue);
                this.SetTypeface(font, TypefaceStyle.Normal);
            }
            catch (Exception)
            {

            }
        }

        private Typeface ObtainTypeface(Context context, int typefaceValue)
        {
            try
            {
                Typeface typeface = null;
                if (Typefaces.ContainsKey(typefaceValue))
                    typeface = Typefaces[typefaceValue];

                if (typeface == null)
                {
                    typeface = this.CreateTypeface(context, typefaceValue);
                    Typefaces.Add(typefaceValue, typeface);
                }
                return typeface;
            }
            catch (Exception ex)
            {

            }

            return null;
        }

        private Typeface CreateTypeface(Context context, int typefaceValue)
        {
            try
            {
                Typeface typeface;
                switch (typefaceValue)
                {
                    case ProHealthIcon:
                        typeface = Typeface.CreateFromAsset(context.Assets, Constants.ProHealthIconFontPath);
                        break;
                    default:
                        throw new ArgumentException("Unknown typeface attribute value " + typefaceValue);
                }
                return typeface;

            }
            catch (Exception)
            {
            }

            return null;
        }
    }
}
