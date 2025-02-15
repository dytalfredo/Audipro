using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System;

namespace Audipro
{
	public class EfectoMenu : GroupBox
	{
		//Fields
private int borderSize = 0;
private int borderRadius = 20;
private Color borderColor = Color.PaleVioletRed;

//Properties
[Category("RJ Code Advance")]
public int BorderSize
{
    get { return borderSize; }
    set
    {
        borderSize = value;
        this.Invalidate();
    }
}

[Category("RJ Code Advance")]
public int BorderRadius
{
    get { return borderRadius; }
    set
    {        
        borderRadius = value;       
        this.Invalidate();
    }
}

[Category("RJ Code Advance")]
public Color BorderColor
{
    get { return borderColor; }
    set
    {
        borderColor = value;
        this.Invalidate();
    }
}
[Category("RJ Code Advance")]
public Color BackgroundColor
{
    get { return this.BackColor; }
    set { this.BackColor = value; }
}

[Category("RJ Code Advance")]
public Color TextColor
{
    get { return this.ForeColor; }
    set { this.ForeColor = value; }
}
	
			//Constructor
public EfectoMenu()
{
    this.FlatStyle = FlatStyle.Flat;
   
    this.Size = new Size(150, 40);
    this.BackColor = Color.MediumSlateBlue;
    this.ForeColor = Color.White;
    this.Resize += new EventHandler(Button_Resize);
}

//Methods
private GraphicsPath GetFigurePath(Rectangle rect, float radius)
{
    GraphicsPath path = new GraphicsPath();
    float curveSize = radius * 2F;

 path.StartFigure();

    // Vertice izquierdo (recto)
    path.AddLine(rect.X, rect.Y, rect.X, rect.Y); // Punto de inicio

    // Vertice derecho (curvo)
    path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);

    // Lado derecho (recto)
    path.AddLine(rect.Right, rect.Y + radius, rect.Right, rect.Bottom);

    // Vertice inferior derecho (recto)
    path.AddLine(rect.Right, rect.Bottom, rect.Right, rect.Bottom); // Punto final del lado derecho

    // Lado inferior (recto)
    path.AddLine(rect.Right, rect.Bottom, rect.X, rect.Bottom);

    // Vertice inferior izquierdo (recto)
    path.AddLine(rect.X, rect.Bottom, rect.X, rect.Bottom); // Punto final del lado inferior

    // Lado izquierdo (recto)
    path.AddLine(rect.X, rect.Bottom, rect.X, rect.Y); // Conectar con el punto de inicio

    path.CloseFigure();
    return path;
}	

private void Button_Resize(object sender, EventArgs e)
{
    if (borderRadius > this.Height)
        borderRadius = this.Height;
}

protected override void OnPaint(PaintEventArgs pevent)
{
    base.OnPaint(pevent);

    Rectangle rectSurface = this.ClientRectangle;
    Rectangle rectBorder = Rectangle.Inflate(rectSurface,-borderSize, -borderSize);
    int smoothSize = 2;
    if (borderSize > 0)
        smoothSize = borderSize;

    if (borderRadius > 2) //Rounded button
    {
        using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
        using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius-borderSize))
        using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
        using (Pen penBorder = new Pen(borderColor, borderSize))
        {
             pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            //Button surface
            this.Region = new Region(pathSurface);
            //Draw surface border for HD result
            pevent.Graphics.DrawPath(penSurface, pathSurface);

            //Button border                    
            if (borderSize >= 1)
                //Draw control border
                pevent.Graphics.DrawPath(penBorder, pathBorder);
        }
    }
    else //Normal button
    {
        pevent.Graphics.SmoothingMode = SmoothingMode.None;
        //Button surface
        this.Region = new Region(rectSurface);
        //Button border
        if (borderSize >= 1)
        {
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = PenAlignment.Inset;
                pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
            }
        }
    }
}

protected override void OnHandleCreated(EventArgs e)
{
    base.OnHandleCreated(e);
    this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
}

private void Container_BackColorChanged(object sender, EventArgs e)
{
    this.Invalidate();
}
		}
	}


