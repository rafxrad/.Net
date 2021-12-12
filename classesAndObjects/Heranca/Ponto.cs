namespace Classes
{
    public class Ponto
    {
        public int x, y;
        private int distancia;

        public Ponto (int x, int y){
            x = this.x;
            y = this.y;
        }

        public int CalcularDistancia(int x, int y)
        {
            return x * y;
        }

        private void CalcularDistancia2()
        {

        }

        public virtual void CalcularDistancia3()
        {
            //
        }



    }
}

// public: qualquer parte do código pode acessar
// protected: apenas as classes que herdam têm acesso
// internal: só é acessado de dentro do assembly que está contido (projects)
// private: único e exclusivamente dentro da classe que está contido