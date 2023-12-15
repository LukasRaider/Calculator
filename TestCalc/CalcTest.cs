namespace TestCalc {
  [TestClass]
  public class CalcTest {
    //[AssemblyInitialize]     //před všemi testy v projektu
    //[ClassInitialize]        //před všemi testy ve třídě
    //[TestInitialize]         //před každou testovací metodou (ve třídě)
    //[TestCleanup]            //po každé testovací metodě (ve třídě)
    //[ClassCleanup]           //po celé testovací třídě
    //[AssemblyCleanup]        //po celém projektu
    Calc calculator;
    [TestInitialize]
    public void Init() {
      calculator = new Calc();
    }
    
    [TestMethod]
    public void Add5Plus1Is6() {
      Calc calculator = new Calc();
      int actual = calculator.Add(5, 1);
      Assert.AreEqual(6, actual);                    //porovnává výsledek actual s tím, co by to mělo vrátit (6)      
    }
    [TestMethod]
    public void Substract2From10Is8() {
      //Calc calc = new Calc();
      Assert.AreEqual(8, calculator.Substract(10, 2));
    }
  }
}