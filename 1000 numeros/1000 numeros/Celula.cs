namespace _1000_numeros
{
    public class Celula
    {
        Celula proxima;
        Celula anterior;
        int elemento;
        public Celula(int element)
        {
            elemento = element;
            proxima = null;
            anterior = null;
        }
        public Celula(Celula proxima, int elemento)
        {
            this.proxima = proxima;
            this.anterior = null;
            this.elemento = elemento;
        }
        public void setProxima(Celula prox)
        {
            proxima = prox;
        }
        public void setAnterior(Celula ant)
        {
            anterior = ant;
        }
        public Celula getProxima()
        {
            return proxima;
        }
        public Celula getAnterior()
        {
            return anterior;
        }
        public int getElemento()
        {
            return elemento;
        }
    }
}