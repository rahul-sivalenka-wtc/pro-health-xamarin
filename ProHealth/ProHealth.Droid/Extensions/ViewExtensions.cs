using Android.Views;
using Android.Views.Animations;

namespace ProHealth.Droid.Extensions
{
    public static class ViewExtensions
    {
        private const int defaultAnimationDuration = 500;

        public static Animation Translate(
            this View view,
            float fromX, float toX,
            float fromY, float toY,
            long duration = defaultAnimationDuration)
        {
            var animation = new TranslateAnimation(fromX, toX, fromY, toY);
            animation.Duration = duration;
            animation.Interpolator = new AccelerateDecelerateInterpolator();
            return animation;
        }

        public static Animation TranslateX(
            this View view,
            float fromX, float toX,
            long duration = defaultAnimationDuration)
        {
            return Translate(view, fromX, toX, 0, 0, duration);
        }

        public static Animation TranslateY(this View view, float fromY, float toY, long duration = defaultAnimationDuration)
        {
            return Translate(view, 0, 0, fromY, toY, duration);
        }

        public static Animation Fade(
            this View view,
            float fromAlpha = 1.0f,
            float toAlpha = 0.0f,
            long duration = defaultAnimationDuration)
        {
            Animation animation = new AlphaAnimation(fromAlpha, toAlpha);
            animation.Duration = duration;
            return animation;
        }
    }
}