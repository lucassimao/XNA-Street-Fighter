using Microsoft.Xna.Framework;

namespace Street_Fighter.interfaces
{
    // Esta interface representa qualquer coisa que tenha a capacidade de ser "movimentável".
    // A class Fighter é uma classe que implementa este comportamento
    public interface IMoveable
    {
        // informa deslocamentos à serem feitos pelo objeto. Veja bem, é deslocamento, NÃO distância:
        // Se um objeto que implementa esta interface estiver na posião (10,2) e o método incrementCurrentPosition
        // é chamado com os parâmetros (-2,3) a nova posição do objeto será (8,5)
        void incrementCurrentPosition(float xInc, float yInc);
    }
}
