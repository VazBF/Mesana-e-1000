using _1000_numeros;
using System;
using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main()
    {
        int[] v = new int[1000];
        Random random = new Random();
        ListaDupla listaCrescente = new ListaDupla();
        ListaDupla listaDecrescente = new ListaDupla();
        String impressao = "";
        for (int i = 0; i < 1000; i++)
        {
            v[i] = random.Next(-9999, 9999);
            if (i == 0)
            {
                listaCrescente.addEnd(v[i]);
            }
            else
            {
                if (v[i] <= listaCrescente.getFirst().getElemento())
                {
                    listaCrescente.addBeginning(v[i]);
                }else if (v[i] >= listaCrescente.getLast().getElemento())
                {
                    listaCrescente.addEnd(v[i]);
                }else if(i == 2){
                    listaCrescente.addInPos(1, v[i]);
                }
                else
                {
                    Celula aux = listaCrescente.getFirst().getProxima();
                    for (int j = 1; j < listaCrescente.lenght(); j++)
                    {
                        if (v[i] <= aux.getElemento())
                        {
                            listaCrescente.addInPos(j, v[i]);
                            break;
                        }
                        aux = aux.getProxima();
                    }
                }
            }
        }

        for(int i = 0; i < 1000; i++)
        {
            if (i == 0)
            {
                listaDecrescente.addEnd(v[i]);
            }
            else
            {
                if (v[i] >= listaDecrescente.getFirst().getElemento())
                {
                    listaDecrescente.addBeginning(v[i]);
                }
                else if (v[i] <= listaDecrescente.getLast().getElemento())
                {
                    listaDecrescente.addEnd(v[i]);
                }
                else if (i == 2)
                {
                    listaDecrescente.addInPos(1, v[i]);
                }
                else
                {
                    Celula aux = listaDecrescente.getFirst().getProxima();
                    for (int j = 1; j < listaDecrescente.lenght(); j++)
                    {
                        if (v[i] >= aux.getElemento())
                        {
                            listaDecrescente.addInPos(j, v[i]);
                            break;
                        }
                        aux = aux.getProxima();
                    }
                }
            }
        }

        for (int i = 0; i < 1000; i++)
        {
            impressao = impressao + "  " + v[i];
        }
        Console.WriteLine(impressao + "\n\n\n\n\n\n");
        impressao = "";
        for (int i = 0; i < 1000; i++)
        {
            impressao = impressao + listaCrescente.GetCelula(i).getElemento() + "  ";
        }

        Console.WriteLine(impressao + "\n\n\n\n\n\n");
        impressao = "";
        for (int i = 0; i < 1000; i++)
        {
            impressao = impressao + listaDecrescente.GetCelula(i).getElemento() + "  ";
        }
        Console.WriteLine(impressao);
    }
}