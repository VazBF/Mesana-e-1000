namespace Megasena
{
    class Program
    {
        static void Main()
        {
            int tamanhoLista = 10000;
            ListaDupla lista = new ListaDupla();
            ListaDupla posicoesDireta = new ListaDupla();
            ListaDupla posicoesIndireta = new ListaDupla();
            int qtd = 0;
            Random random = new Random();
            int[] pos = new int[6];
            //[1,15,16,25,32,36]
            /*
            lista.addEnd(1);
            lista.addEnd(15);
            lista.addEnd(16);
            lista.addEnd(25);
            lista.addEnd(32);
            lista.addEnd(36);

            lista.addEnd(32);
            lista.addEnd(25);
            lista.addEnd(16);
            lista.addEnd(15);
            lista.addEnd(1);
            */
            for (int i = 0; i < tamanhoLista; i++)
            {
                lista.addEnd(random.Next(0, 100));
            }
            for (int i = 0; i < tamanhoLista; i++)
            {
                if (lista.GetCelula(i).getElemento() == 1 && i <= tamanhoLista - 6)
                {
                    pos[0] = i;
                    if (lista.GetCelula(i + 1).getElemento() == 15)
                    {
                        pos[1] = i + 1;
                        if (lista.GetCelula(i + 2).getElemento() == 16)
                        {
                            pos[2] = i + 2;
                            if (lista.GetCelula(i + 3).getElemento() == 25)
                            {
                                pos[3] = i + 3;
                                if (lista.GetCelula(i + 4).getElemento() == 32)
                                {
                                    pos[4] = i + 4;
                                    if (lista.GetCelula(i + 5).getElemento() == 36)
                                    {
                                        pos[5] = i + 5;
                                        posicoesDireta.addEnd(pos[0]);
                                        posicoesDireta.addEnd(pos[1]);
                                        posicoesDireta.addEnd(pos[2]);
                                        posicoesDireta.addEnd(pos[3]);
                                        posicoesDireta.addEnd(pos[4]);
                                        posicoesDireta.addEnd(pos[5]);
                                        qtd++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Quantidade de vezes que a sequencia aparece é de: " + qtd);
            if (qtd != 0)
            {
                int count = 0;
                Console.WriteLine("\nA sequencia aparece na ordem direta nas seguintes posicoes: ");
                for (int i = 0; i < qtd; i++)
                {
                    Console.WriteLine("Seuquencia {0}:", i + 1);
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine("" + posicoesDireta.GetCelula(j + count).getElemento());
                    }
                }
            }
            else
            {
                Console.WriteLine("A sequência não aparece nem uma vez na ordem direta.");
            }
            qtd = 0;
            for (int i = tamanhoLista - 1; i >= 0; i--)
            {
                if (lista.GetCelula(i).getElemento() == 1 && i >= 6)
                {
                    pos[0] = i;
                    if (lista.GetCelula(i - 1).getElemento() == 15)
                    {
                        pos[1] = i - 1;
                        if (lista.GetCelula(i - 2).getElemento() == 16)
                        {
                            pos[2] = i - 2;
                            if (lista.GetCelula(i - 3).getElemento() == 25)
                            {
                                pos[3] = i - 3;
                                if (lista.GetCelula(i - 4).getElemento() == 32)
                                {
                                    pos[4] = i - 4;
                                    if (lista.GetCelula(i - 5).getElemento() == 36)
                                    {
                                        pos[5] = i - 5;
                                        posicoesIndireta.addEnd(pos[0]);
                                        posicoesIndireta.addEnd(pos[1]);
                                        posicoesIndireta.addEnd(pos[2]);
                                        posicoesIndireta.addEnd(pos[3]);
                                        posicoesIndireta.addEnd(pos[4]);
                                        posicoesIndireta.addEnd(pos[5]);
                                        qtd++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine("\n\n\nQuantidade de vezes que a sequencia aparece é de: " + qtd);
            if (qtd != 0)
            {
                int count = 0;
                Console.WriteLine("\nA sequencia aparece na ordem inversa nas seguintes posicoes: ");
                for (int i = 0; i < qtd; i++)
                {
                    Console.WriteLine("Sequencia {0}:", i + 1);
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine("" + posicoesIndireta.GetCelula(j + count).getElemento());
                    }
                }
            }
            else
            {
                Console.WriteLine("A sequência não aparece nem uma vez na ordem inversa.");
            }

        }
    }
}
