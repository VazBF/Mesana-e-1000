namespace _1000_numeros
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

        public void addInPos(int pos, int element)
        {
            if (pos == 0)
            {
                this.addBeginning(element);
            }else if(pos == qtdElement)
            {
                this.addEnd(element);
            }
            else
            {
                Celula anterior = this.GetCelula(pos - 1);
                Celula proxima = anterior.getProxima();
                Celula nova = new Celula(anterior.getProxima(), element);
                nova.setAnterior(anterior);
                anterior.setProxima(nova);
                proxima.setAnterior(nova);
                this.qtdElement++;
            }
        }

        public Celula getFirst()
        {
            return first;
        }
        public Celula getLast()
        {
            return last;
        }
    }
}
