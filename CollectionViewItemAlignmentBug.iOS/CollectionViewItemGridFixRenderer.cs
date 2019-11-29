using System;
using CoreGraphics;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

//[assembly: ExportRenderer(typeof(Grid), typeof(CollectionViewItemAlignmentBug.iOS.CollectionViewItemGridFixRenderer))]
namespace CollectionViewItemAlignmentBug.iOS
{
    public class CollectionViewItemGridFixRenderer : VisualElementRenderer<Grid>
    {
        public override CGRect Bounds
        {
            get => base.Bounds;
            set
            {
                //Debug.WriteLine($"set bounds {value}");

                base.Bounds = value.Width < 0 || value.Height < 0
                    ? new CGRect(value.X, value.Y, Math.Max(value.Width, 0), Math.Max(value.Height, 0))
                    : value;
            }
        }
    }
}