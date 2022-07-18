
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

            if (currentPixel.R != 0 &&
            currentPixel.G != 0 &&
            currentPixel.B != 0 &&
            currentPixel.A == 0) {
                currentPixel.R = 0;
                currentPixel.G = 0;
                currentPixel.B = 0;
                currentPixel.A = 0;

            }

            dst[x,y] = currentPixel;
        }
    }
}
