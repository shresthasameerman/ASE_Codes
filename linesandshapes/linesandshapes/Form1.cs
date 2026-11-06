namespace linesandshapes;

public partial class Form1 : Form
{
    // ---- car data ----
    float carX = 50;          // left edge of the car
    float speed = 4;          // how many pixels it moves each tick
    bool running = false;     // is the car moving?
    float wheelAngle = 0;     // makes the wheel spokes spin
    int carWidth = 200;

    // ---- colors ----
    Color[] colors = { Color.Crimson, Color.RoyalBlue, Color.Gold, Color.SeaGreen, Color.DarkOrange };
    int colorIndex = 0;

    // ---- pens and brushes (made once, reused) ----
    Pen blackPen = new Pen(Color.Black, 3);
    Pen whitePen = new Pen(Color.White, 4);
    Pen spokePen = new Pen(Color.Silver, 3);
    SolidBrush bodyBrush = new SolidBrush(Color.Crimson);
    SolidBrush skyBrush = new SolidBrush(Color.LightSkyBlue);
    SolidBrush roadBrush = new SolidBrush(Color.DimGray);
    SolidBrush sunBrush = new SolidBrush(Color.Gold);
    SolidBrush glassBrush = new SolidBrush(Color.LightCyan);
    SolidBrush tireBrush = new SolidBrush(Color.Black);
    SolidBrush hubBrush = new SolidBrush(Color.LightGray);
    SolidBrush lightBrush = new SolidBrush(Color.Yellow);
    SolidBrush tailBrush = new SolidBrush(Color.Red);

    // ---- timer and buttons ----
    System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
    Button btnStart = new Button();
    Button btnReverse = new Button();
    Button btnFaster = new Button();
    Button btnSlower = new Button();
    Button btnColor = new Button();
    Button btnReset = new Button();

    public Form1()
    {
        InitializeComponent();

        this.Text = "Car Demo";
        this.DoubleBuffered = true;     // stops flickering
        this.ResizeRedraw = true;       // redraw when window is resized
        this.Width = 900;
        this.Height = 500;

        // set up the buttons (text, position, size)
        SetupButton(btnStart, "Start", 10);
        SetupButton(btnReverse, "Reverse", 120);
        SetupButton(btnFaster, "Faster", 230);
        SetupButton(btnSlower, "Slower", 340);
        SetupButton(btnColor, "Color", 450);
        SetupButton(btnReset, "Reset", 560);

        // connect each button to its method
        btnStart.Click += btnStart_Click;
        btnReverse.Click += btnReverse_Click;
        btnFaster.Click += btnFaster_Click;
        btnSlower.Click += btnSlower_Click;
        btnColor.Click += btnColor_Click;
        btnReset.Click += btnReset_Click;

        // set up the timer
        timer.Interval = 16;            // about 60 times per second
        timer.Tick += timer_Tick;
        timer.Start();
    }

    // ------------------------------------------------------------
    // The designer file expects this method to exist.
    // It can stay empty.
    // ------------------------------------------------------------
    private void Form1_Load(object? sender, EventArgs e)
    {
    }

    // ------------------------------------------------------------
    // Button setup helper
    // ------------------------------------------------------------
    void SetupButton(Button b, string text, int x)
    {
        b.Text = text;
        b.Width = 100;
        b.Height = 36;
        b.Left = x;
        b.Top = this.ClientSize.Height - 46;
        b.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;   // stays at the bottom
        this.Controls.Add(b);
    }

    // ------------------------------------------------------------
    // Button click methods
    // ------------------------------------------------------------
    void btnStart_Click(object? sender, EventArgs e)
    {
        running = !running;             // flip true/false
        if (running)
            btnStart.Text = "Stop";
        else
            btnStart.Text = "Start";
    }

    void btnReverse_Click(object? sender, EventArgs e)
    {
        speed = -speed;
    }

    void btnFaster_Click(object? sender, EventArgs e)
    {
        speed = speed * 1.3f;
        if (speed > 30) speed = 30;
        if (speed < -30) speed = -30;
    }

    void btnSlower_Click(object? sender, EventArgs e)
    {
        speed = speed * 0.7f;
    }

    void btnColor_Click(object? sender, EventArgs e)
    {
        colorIndex = colorIndex + 1;
        if (colorIndex >= colors.Length) colorIndex = 0;
        bodyBrush.Color = colors[colorIndex];
        Invalidate();                   // redraw the form
    }

    void btnReset_Click(object? sender, EventArgs e)
    {
        carX = 50;
        speed = 4;
        running = false;
        btnStart.Text = "Start";
        Invalidate();
    }

    // ------------------------------------------------------------
    // Timer: runs every 16 ms
    // ------------------------------------------------------------
    void timer_Tick(object? sender, EventArgs e)
    {
        if (running)
        {
            carX = carX + speed;
            wheelAngle = wheelAngle + speed * 3;

            // wrap around when the car leaves the screen
            if (carX > this.ClientSize.Width) carX = -carWidth;
            if (carX < -carWidth) carX = this.ClientSize.Width;
        }
        Invalidate();                   // ask Windows to call OnPaint again
    }

    // ------------------------------------------------------------
    // Drawing
    // ------------------------------------------------------------
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics g = e.Graphics;

        int roadHeight = 70;
        int roadTop = this.ClientSize.Height - 60 - roadHeight;   // 60 = space for buttons

        // Sky
        g.FillRectangle(skyBrush, 0, 0, this.ClientSize.Width, roadTop);

        // Sun
        g.FillEllipse(sunBrush, this.ClientSize.Width - 120, 30, 70, 70);

        // Road
        g.FillRectangle(roadBrush, 0, roadTop, this.ClientSize.Width, roadHeight);

        // Dashed center line: lots of short lines drawn in a loop
        for (int x = 0; x < this.ClientSize.Width; x = x + 40)
        {
            g.DrawLine(whitePen, x, roadTop + 35, x + 20, roadTop + 35);
        }

        // Ground under the buttons
        g.FillRectangle(Brushes.DarkGreen, 0, roadTop + roadHeight, this.ClientSize.Width, 60);

        DrawCar(g, carX, roadTop);
    }

    void DrawCar(Graphics g, float x, int roadTop)
    {
        float baseY = roadTop + 40;     // bottom of the car body

        // Roof (a 4-point filled shape)
        PointF[] roof = new PointF[4];
        roof[0] = new PointF(x + 40, baseY - 45);
        roof[1] = new PointF(x + 70, baseY - 85);
        roof[2] = new PointF(x + 140, baseY - 85);
        roof[3] = new PointF(x + 170, baseY - 45);
        g.FillPolygon(bodyBrush, roof);
        g.DrawPolygon(blackPen, roof);

        // Window 1
        PointF[] win1 = new PointF[4];
        win1[0] = new PointF(x + 52, baseY - 48);
        win1[1] = new PointF(x + 75, baseY - 78);
        win1[2] = new PointF(x + 100, baseY - 78);
        win1[3] = new PointF(x + 100, baseY - 48);
        g.FillPolygon(glassBrush, win1);

        // Window 2
        PointF[] win2 = new PointF[4];
        win2[0] = new PointF(x + 108, baseY - 48);
        win2[1] = new PointF(x + 108, baseY - 78);
        win2[2] = new PointF(x + 135, baseY - 78);
        win2[3] = new PointF(x + 158, baseY - 48);
        g.FillPolygon(glassBrush, win2);

        // Body (filled rectangle, then outline on top)
        g.FillRectangle(bodyBrush, x, baseY - 45, carWidth, 45);
        g.DrawRectangle(blackPen, x, baseY - 45, carWidth, 45);

        // Headlight and taillight
        g.FillEllipse(lightBrush, x + carWidth - 14, baseY - 36, 12, 12);
        g.FillRectangle(tailBrush, x, baseY - 36, 8, 12);

        // Wheels
        DrawWheel(g, x + 45, baseY);
        DrawWheel(g, x + 155, baseY);
    }

    void DrawWheel(Graphics g, float cx, float cy)
    {
        float r = 22;

        // tire and hubcap
        g.FillEllipse(tireBrush, cx - r, cy - r, r * 2, r * 2);
        g.FillEllipse(hubBrush, cx - 12, cy - 12, 24, 24);

        // two spokes that rotate with wheelAngle
        for (int i = 0; i < 2; i++)
        {
            double a = (wheelAngle + i * 90) * Math.PI / 180;
            float dx = (float)Math.Cos(a) * 11;
            float dy = (float)Math.Sin(a) * 11;
            g.DrawLine(spokePen, cx - dx, cy - dy, cx + dx, cy + dy);
        }
    }
}