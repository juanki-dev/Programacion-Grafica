using System;
using static Repisa;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

public class Game : GameWindow
{
    private float rotationX = 0.0f;
    private float rotationY = 0.0f;
    private float lastX;
    private float lastY;
    private bool mouseDown;

    public Game(int width, int height) : base(width, height, GraphicsMode.Default, "TAREA") { }

        protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        GL.ClearColor(Color4.Brown);
        GL.Enable(EnableCap.DepthTest);

        GL.Viewport(0, 0, Width, Height);
        GL.MatrixMode(MatrixMode.Projection);
        GL.LoadIdentity();
        Matrix4 perspective = Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver4, Width / (float)Height, 1.0f, 100.0f);
        GL.LoadMatrix(ref perspective);

        MouseMove += (sender, args) =>
        {
            if (mouseDown)
            {
                float deltaX = args.X - lastX;
                float deltaY = args.Y - lastY;
                rotationX += deltaY * 0.01f;
                rotationY += deltaX * 0.01f;
            }
            lastX = args.X;
            lastY = args.Y;
        };

        MouseDown += (sender, args) =>
        {
            if (args.Button == MouseButton.Left)
            {
                mouseDown = true;
            }
        };

        MouseUp += (sender, args) =>
        {
            if (args.Button == MouseButton.Left)
            {
                mouseDown = false;
            }
        };
    }

    protected override void OnUpdateFrame(FrameEventArgs e)
    {
        base.OnUpdateFrame(e);

        KeyboardState keyboardState = Keyboard.GetState();
        if (keyboardState.IsKeyDown(Key.Escape))
        {
            Exit();
            return;
        }
    }

    protected override void OnRenderFrame(FrameEventArgs e)
    {
        base.OnRenderFrame(e);

        GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

        GL.MatrixMode(MatrixMode.Modelview);
        GL.LoadIdentity();
        GL.Translate(0.0f, 0.0f, -5.0f); // Posición de la cámara
        GL.Rotate(rotationX, Vector3.UnitX);
        GL.Rotate(rotationY, Vector3.UnitY);


       Estante();

        SwapBuffers();
    }
}
