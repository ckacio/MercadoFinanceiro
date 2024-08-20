
namespace MercadoFinanceiro
{
    public class PercentageOfVolumePOV
    {

        /*
         * A estratégia Percentage of Volume (POV) é utilizada quando o cliente quer executar 
         * uma quantidade que acompanhe um determinado percentual do volume negociado de um papel 
         * no mercado. Por exemplo, o cliente quer fazer 10% do volume do papel PETR4. 
         * Ao serem negociadas 1000 ações no total do papel no mercado, é esperado que 100 ações 
         * desse total tenham sido executadas por essa estratégia. A função abaixo com a 
         * porcentagem e o número de ações negociadas informados, retorna o valor de ações que devem ser 
         * negociadas pela estratégia POV para atingir o volume esperado. 
         */
        public static decimal FuncaoRetornaQuantidade(decimal porcentagem, int totalNegociado)
        {
            return (int)(totalNegociado * porcentagem) / ((1 - porcentagem));
        }


    }
}
