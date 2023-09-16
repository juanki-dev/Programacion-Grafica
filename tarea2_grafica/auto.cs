using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

public static class Auto
{
public static void Carro(float horizontalHeight)
{
    // Dimensiones del automóvil
    float carWidth = 0.1f;
    float carHeight = 0.1f;
    float carLength = 0.1f;
    float wheelRadius = 0.03f;
    float wheelOffsetY = -carHeight / 2;
    float wheelOffsetX = carWidth / 4;

    // Posición del automóvil encima del rectángulo horizontal
    float carX = 0.0f;
    float carY = horizontalHeight / 2 + carHeight / 2; 
    float carZ = 0.0f;

    GL.Begin(PrimitiveType.Quads);
    GL.Color4(Color4.Blue);

    // Base del automóvil
    GL.Vertex3(carX - carWidth / 2, carY - carHeight / 2, carZ - carLength / 2);
    GL.Vertex3(carX + carWidth / 2, carY - carHeight / 2, carZ - carLength / 2);
    GL.Vertex3(carX + carWidth / 2, carY - carHeight / 2, carZ + carLength / 2);
    GL.Vertex3(carX - carWidth / 2, carY - carHeight / 2, carZ + carLength / 2);

    // Parte superior del automóvil
    GL.Vertex3(carX - carWidth / 2, carY + carHeight / 2, carZ - carLength / 2);
    GL.Vertex3(carX + carWidth / 2, carY + carHeight / 2, carZ - carLength / 2);
    GL.Vertex3(carX + carWidth / 2, carY + carHeight / 2, carZ + carLength / 2);
    GL.Vertex3(carX - carWidth / 2, carY + carHeight / 2, carZ + carLength / 2);

    // Lados del automóvil
    GL.Vertex3(carX - carWidth / 2, carY - carHeight / 2, carZ - carLength / 2);
    GL.Vertex3(carX + carWidth / 2, carY - carHeight / 2, carZ - carLength / 2);
    GL.Vertex3(carX + carWidth / 2, carY + carHeight / 2, carZ - carLength / 2);
    GL.Vertex3(carX - carWidth / 2, carY + carHeight / 2, carZ - carLength / 2);

    GL.Vertex3(carX - carWidth / 2, carY - carHeight / 2, carZ + carLength / 2);
    GL.Vertex3(carX + carWidth / 2, carY - carHeight / 2, carZ + carLength / 2);
    GL.Vertex3(carX + carWidth / 2, carY + carHeight / 2, carZ + carLength / 2);
    GL.Vertex3(carX - carWidth / 2, carY + carHeight / 2, carZ + carLength / 2);

    GL.End();

    // Dibuja las ruedas del automóvil
    Ruedas(carX - wheelOffsetX, carY + wheelOffsetY, carZ - carLength / 2, wheelRadius);
    Ruedas(carX + wheelOffsetX, carY + wheelOffsetY, carZ - carLength / 2, wheelRadius);
    Ruedas(carX - wheelOffsetX, carY + wheelOffsetY, carZ + carLength / 2, wheelRadius);
    Ruedas(carX + wheelOffsetX, carY + wheelOffsetY, carZ + carLength / 2, wheelRadius);
}

public static void Ruedas(float x, float y, float z, float radius)
{
    int segments = 30;
    float angleIncrement = (float)(2.0 * Math.PI / segments);

    GL.Color4(Color4.Black);
    GL.Begin(PrimitiveType.TriangleFan);

    // Centro de la rueda
    GL.Vertex3(x, y, z);

    // Vértices de la circunferencia
    for (int i = 0; i <= segments; i++)
    {
        float angle = i * angleIncrement;
        float vx = (float)(x + radius * Math.Cos(angle));
        float vy = (float)(y + radius * Math.Sin(angle));
        GL.Vertex3(vx, vy, z);
    }

    GL.End();
}
}
