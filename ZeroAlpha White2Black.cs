
#region UICode
ColorWheelControl changeFrom = ColorBgra.FromBgr(255, 255, 255); // [White] Color to change from
ColorWheelControl changeTo = ColorBgra.FromBgr(0, 0, 0); // [Black] Color to change to
#endregion

void Render(Surface dst, Surface src, Rectangle rect)
{
    Rectangle selection = EnvironmentParameters.SelectionBounds;

    ColorBgra currentPixel;
    for (int y = rect.Top; y < rect.Bottom; y++)
    {
        if (IsCancelRequested) return;
        for (int x = rect.Left; x < rect.Right; x++)
        {
            currentPixel = src[x,y];
            if (currentPixel.R == changeFrom.R &&
            currentPixel.G == changeFrom.G &&
            currentPixel.B == changeFrom.B &&
            currentPixel.A == 0) {
                currentPixel.R = changeTo.R;
                currentPixel.G = changeTo.G;
                currentPixel.B = changeTo.B;
                currentPixel.A = 0;

            }

            dst[x,y] = currentPixel;
        }
    }
}
