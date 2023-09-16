using static Auto;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

public static class Repisa
{
public static void Estante()
{
    float rectWidth = 2.0f;
    float rectHeight = 4.0f;
    float rectDepth = 0.4f;

    // Posición del rectángulo vertical
    float verticalX = -1.0f;
    float verticalY = 0.0f;
    float verticalZ = 0.0f;

    

    // Dimensiones del rectángulo horizontal en el medio
    float horizontalWidth = 2.0f;
    float horizontalHeight = 1.0f;
    float horizontalDepth = 0.3f;

    // Dibuja el rectángulo vertical
    GL.Color4(Color4.Gray);
    GL.Begin(PrimitiveType.Quads);
    
    // Base inferior
    GL.Vertex3(verticalX - rectWidth / 2, verticalY - rectHeight / 2, verticalZ - rectDepth / 2);
    GL.Vertex3(verticalX + rectWidth / 2, verticalY - rectHeight / 2, verticalZ - rectDepth / 2);
    GL.Vertex3(verticalX + rectWidth / 2, verticalY - rectHeight / 2, verticalZ + rectDepth / 2);
    GL.Vertex3(verticalX - rectWidth / 2, verticalY - rectHeight / 2, verticalZ + rectDepth / 2);

    // Base superior
    GL.Vertex3(verticalX - rectWidth / 2, verticalY + rectHeight / 2, verticalZ - rectDepth / 2);
    GL.Vertex3(verticalX + rectWidth / 2, verticalY + rectHeight / 2, verticalZ - rectDepth / 2);
    GL.Vertex3(verticalX + rectWidth / 2, verticalY + rectHeight / 2, verticalZ + rectDepth / 2);
    GL.Vertex3(verticalX - rectWidth / 2, verticalY + rectHeight / 2, verticalZ + rectDepth / 2);

    // Lado izquierdo
    GL.Vertex3(verticalX - rectWidth / 2, verticalY - rectHeight / 2, verticalZ - rectDepth / 2);
    GL.Vertex3(verticalX + rectWidth / 2, verticalY - rectHeight / 2, verticalZ - rectDepth / 2);
    GL.Vertex3(verticalX + rectWidth / 2, verticalY + rectHeight / 2, verticalZ - rectDepth / 2);
    GL.Vertex3(verticalX - rectWidth / 2, verticalY + rectHeight / 2, verticalZ - rectDepth / 2);

    // Lado derecho
    GL.Vertex3(verticalX - rectWidth / 2, verticalY - rectHeight / 2, verticalZ + rectDepth / 2);
    GL.Vertex3(verticalX + rectWidth / 2, verticalY - rectHeight / 2, verticalZ + rectDepth / 2);
    GL.Vertex3(verticalX + rectWidth / 2, verticalY + rectHeight / 2, verticalZ + rectDepth / 2);
    GL.Vertex3(verticalX - rectWidth / 2, verticalY + rectHeight / 2, verticalZ + rectDepth / 2);

    GL.End();

    // Dibuja el rectángulo horizontal en el medio
    GL.Color4(Color4.Yellow);
    GL.Begin(PrimitiveType.Quads);
    
    // Base inferior
    GL.Vertex3(verticalX - horizontalWidth / 2, verticalY - horizontalHeight / 2, verticalZ - horizontalDepth / 2);
    GL.Vertex3(verticalX + horizontalWidth / 2, verticalY - horizontalHeight / 2, verticalZ - horizontalDepth / 2);
    GL.Vertex3(verticalX + horizontalWidth / 2, verticalY - horizontalHeight / 2, verticalZ + horizontalDepth / 2);
    GL.Vertex3(verticalX - horizontalWidth / 2, verticalY - horizontalHeight / 2, verticalZ + horizontalDepth / 2);

    // Base superior
    GL.Vertex3(verticalX - horizontalWidth / 2, verticalY + horizontalHeight / 2, verticalZ - horizontalDepth / 2);
    GL.Vertex3(verticalX + horizontalWidth / 2, verticalY + horizontalHeight / 2, verticalZ - horizontalDepth / 2);
    GL.Vertex3(verticalX + horizontalWidth / 2, verticalY + horizontalHeight / 2, verticalZ + horizontalDepth / 2);
    GL.Vertex3(verticalX - horizontalWidth / 2, verticalY + horizontalHeight / 2, verticalZ + horizontalDepth / 2);

    // Lado izquierdo
    GL.Vertex3(verticalX - horizontalWidth / 2, verticalY - horizontalHeight / 2, verticalZ - horizontalDepth / 2);
    GL.Vertex3(verticalX + horizontalWidth / 2, verticalY - horizontalHeight / 2, verticalZ - horizontalDepth / 2);
    GL.Vertex3(verticalX + horizontalWidth / 2, verticalY + horizontalHeight / 2, verticalZ - horizontalDepth / 2);
    GL.Vertex3(verticalX - horizontalWidth / 2, verticalY + horizontalHeight / 2, verticalZ - horizontalDepth / 2);

    // Lado derecho
    GL.Vertex3(verticalX - horizontalWidth / 2, verticalY - horizontalHeight / 2, verticalZ + horizontalDepth / 2);
    GL.Vertex3(verticalX + horizontalWidth / 2, verticalY - horizontalHeight / 2, verticalZ + horizontalDepth / 2);
    GL.Vertex3(verticalX + horizontalWidth / 2, verticalY + horizontalHeight / 2, verticalZ + horizontalDepth / 2);
    GL.Vertex3(verticalX - horizontalWidth / 2, verticalY + horizontalHeight / 2, verticalZ + horizontalDepth / 2);

    GL.End();
    Carro(horizontalHeight);
 }

}
