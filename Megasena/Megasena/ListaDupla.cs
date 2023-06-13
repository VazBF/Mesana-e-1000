namespace Megasena
{
    public class ListaDupla
    {
        Celula first;
        Celula last;
        int qtdElement = 0;
        public void addBeginning(int element)
        {
            if (qtdElement == 0)
            {
                Celula nova = new Celula(element);
                first = nova;
                last = nova;
                qtdElement++;
            }
            else
            {
                Celula nova = new Celula(first, element);
                first.setAnterior(nova);
                first = nova;
                qtdElement++;
            }
        }
        public void addEnd(int element)
        {
            if (qtdElement == 0)
            {
                addBeginning(element);
            }
            else
            {
                Celula nova = new Celula(element);
                last.setProxima(nova);
                nova.setAnterior(last);
                last = nova;
                qtdElement++;
            }
        }
        public int lenght()
        {
            return qtdElement;
        }
        public Celula GetCelula(int pos)
        {
            if (pos >= 0 && pos <= qtdElement)
            {
                Celula aux = first;
                for (int i = 0; i < pos; i++)
                {
                    aux = aux.getProxima();
                }
                return aux;
            }
            else
            {
                return null;
            }
        }
    }
}
