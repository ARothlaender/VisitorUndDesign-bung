using Bundesbank.Rc1.Übungen.Instruments;
using Bundesbank.Rc1.Übungen.Portfolios;
using System;
using System.Globalization;

namespace Bundesbank.Rc1.Übungen
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program instance = new Program();
            instance.Run();
        }
        public void Run()
        {
            Portfolio samplePortfolio = new Portfolio("Beispielportfolio");
            samplePortfolio.AddPosition(new Position(new CreditInstrument("Deutsche Bank", "DE12345678", "AAA", "EUR"), 1000.0m));
            samplePortfolio.AddPosition(new Position(new CreditInstrument("Deutsche Bank", "DE22345678", "AA", "EUR"), 500.0m));
            samplePortfolio.AddPosition(new Position(new CreditInstrument("Siemens", "DE32345678", "BB", "EUR"), 80.0m));
            samplePortfolio.AddPosition(new Position(new CreditInstrument("Tesla", "US12345678", "C", "USD"), 2300.0m));
            samplePortfolio.AddPosition(new Position(new CreditInstrument("Credit Agricole", "FR22345678", "AA", "EUR"), 175.0m));
            samplePortfolio.AddPosition(new Position(new CreditInstrument("Toblerone", "CH12345678", "AAA", "CHF"), 665.0m));
            samplePortfolio.AddPosition(new Position(new EquityInstrument("Bank of America", "US52345678", "B", "USD"), 340.0m));
            samplePortfolio.AddPosition(new Position(new EquityInstrument("Deutsche Bank", "DE42345678", "CC", "EUR"), 690.0m));
            samplePortfolio.AddPosition(new Position(new CashInstrument("Own Account", "N.A.", "N.A.", "EUR","1337"), 5205.0m));
            samplePortfolio.AddPosition(new Position(new CashInstrument("Own Account", "N.A.", "N.A.", "EUR","5262"), 1000.0m));
            samplePortfolio.AddPosition(new Position(new EquityInstrument("Apple", "US42345678", "BBB", "USD"), 15.0m));

            samplePortfolio.PrintPositions();

        }

    }
}
