using Functions;

[TestClass]
public class Class1Tests
{
    //Menu

    [TestMethod]
    public void Menu_ChoosePlay()
    {
        // Arrange
        int choose = 1;

        // Act
        int result = Class1.Menu(choose);

        // Assert
        Assert.AreEqual(choose, result);
    }

    [TestMethod]
    public void Menu_ChooseExit()
    {
        // Arrange
        int choose = 0;

        // Act
        int result = Class1.Menu(choose);

        // Assert
        Assert.AreEqual(choose, result);
    }

    [TestMethod]
    public void Menu_ChooseInvalid_ReturnsDefault()
    {
        // Arrange
        int choose = 5;

        // Act
        int result = Class1.Menu(choose);

        // Assert
        Assert.AreEqual(0, result);
    }

    //Noms

    [TestMethod]
    public void Noms_InputEmptyArray_ReturnsSameEmptyArray()
    {
        // Arrange
        string[] personatges = new string[4];

        // Act
        string[] result = Class1.Noms(personatges);

        // Assert
        CollectionAssert.AreEqual(personatges, result);

    }

    [TestMethod]
    public void Noms_InputArrayWithSomeNames_ReturnsArrayWithAllNames()
    {
        // Arrange
        string[] personatges = new string[] { "Arnau", "Molano", "Rimbau", "Casares" };

        // Act
        string[] result = Class1.Noms(personatges);

        // Assert
        CollectionAssert.AreEqual(personatges, result);
    }

    //Selector de dificultat

    [TestMethod]
    public void DificultSelectorPersonalized()
    {
        // Arrange
        int dificultat = 3;

        // Act
        int result = Class1.DificultSelector(dificultat);

        // Assert
        Assert.AreEqual(3, result);
    }

    [TestMethod]
    public void DificultSelectorWrong()
    {
        // Arrange
        int dificultat = 5;
       

        // Act
        int result = Class1.DificultSelector(dificultat);

        // Assert
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void DificultSelectorEasy()
    {
        // Arrange
        int dificultat = 1;


        // Act
        int result = Class1.DificultSelector(dificultat);

        // Assert
        Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void DificultSelectorHard()
    {
        // Arrange
        int dificultat = 2;


        // Act
        int result = Class1.DificultSelector(dificultat);

        // Assert
        Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void DificultSelectorRandom()
    {
        // Arrange
        int dificultat = 4;


        // Act
        int result = Class1.DificultSelector(dificultat);

        // Assert
        Assert.AreEqual(4, result);
    }

    [TestMethod]
    public void Defensa1()
    {
        // Arrange
        int RedP1 = 5;
        int RedP2 = 10;
        int RedP3 = 15;
        int RedP4 = 20;
        string[] personatges = { "Personaje1", "Personaje2", "Personaje3", "Personaje4" };
        string personatge = "Personaje1";

        // Act
        int result = Class1.Defensa(personatge, ref RedP1, ref RedP2, ref RedP3, ref RedP4, personatges);

        // Assert
        Assert.AreEqual(10, result);

    }

    [TestMethod]
    public void Defensa2()
    {
        // Arrange
        int RedP1 = 5;
        int RedP2 = 10;
        int RedP3 = 15;
        int RedP4 = 20;
        string[] personatges = { "Personaje1", "Personaje2", "Personaje3", "Personaje4" };
        string personatge = "Personaje2";

        // Act
        int result = Class1.Defensa(personatge, ref RedP1, ref RedP2, ref RedP3, ref RedP4, personatges);

        // Assert
        Assert.AreEqual(20, result);

    }

    [TestMethod]
    public void Defensa3()
    {
        // Arrange
        int RedP1 = 5;
        int RedP2 = 10;
        int RedP3 = 15;
        int RedP4 = 20;
        string[] personatges = { "Personaje1", "Personaje2", "Personaje3", "Personaje4" };
        string personatge = "Personaje3";

        // Act
        int result = Class1.Defensa(personatge, ref RedP1, ref RedP2, ref RedP3, ref RedP4, personatges);

        // Assert
        Assert.AreEqual(30, result);

    }

    [TestMethod]
    public void Defensa4()
    {
        // Arrange
        int RedP1 = 5;
        int RedP2 = 10;
        int RedP3 = 15;
        int RedP4 = 20;
        string[] personatges = { "Personaje1", "Personaje2", "Personaje3", "Personaje4" };
        string personatge = "Personaje4";

        // Act
        int result = Class1.Defensa(personatge, ref RedP1, ref RedP2, ref RedP3, ref RedP4, personatges);

        // Assert
        Assert.AreEqual(40, result);

    }

    [TestMethod]
    public void HabilitatEspecial_Personatge1_NoquejaMonstre()
    {
        // Arrange
        int vidP1 = 1000;
        int vidP2 = 1200;
        int vidP3 = 800;
        int vidP4 = 900;
        int vidM = 2000;
        int ataP3 = 150;
        int redP2 = 10;
        string[] personajes = { "Personaje1", "Personaje2", "Personaje3", "Personaje4" };
        int hb1 = 0;
        int hb2 = 0;
        int hb3 = 0;
        int hb4 = 0;
        int countHB = 0;
        int auxRedP2 = 0;
        string personaje = "Personaje1";

        // Act
        int result = Class1.HabilitatEspecial(ref vidP1, ref vidP2, ref vidP3, ref vidP4, ref vidM, personaje, ataP3, redP2, personajes, ref hb1, ref hb2, ref hb3, ref hb4, ref countHB, ref auxRedP2);

        // Assert

        Assert.AreEqual(5, hb1);


    }

    [TestMethod]
    public void HabilitatEspecial_Personatge2_AumentaDefensa()
    {
        // Arrange
        int vidP1 = 1000;
        int vidP2 = 1200;
        int vidP3 = 800;
        int vidP4 = 900;
        int vidM = 2000;
        int ataP3 = 150;
        int redP2 = 10;
        string[] personajes = { "Personaje1", "Personaje2", "Personaje3", "Personaje4" };
        int hb1 = 0;
        int hb2 = 0;
        int hb3 = 0;
        int hb4 = 0;
        int countHB = 0;
        int auxRedP2 = 0;
        string personaje = "Personaje2";

        // Act
        int result = Class1.HabilitatEspecial(ref vidP1, ref vidP2, ref vidP3, ref vidP4, ref vidM, personaje, ataP3, redP2, personajes, ref hb1, ref hb2, ref hb3, ref hb4, ref countHB, ref auxRedP2);

        // Assert

        Assert.AreEqual(3, countHB);
        Assert.AreEqual(5, hb2);


    }

    [TestMethod]
    public void HabilitatEspecial_Personatge3()
    {
        // Arrange
        int vidP1 = 1000;
        int vidP2 = 1200;
        int vidP3 = 800;
        int vidP4 = 900;
        int vidM = 2000;
        int ataP3 = 150;
        int redP2 = 10;
        string[] personajes = { "Personaje1", "Personaje2", "Personaje3", "Personaje4" };
        int hb1 = 0;
        int hb2 = 0;
        int hb3 = 0;
        int hb4 = 0;
        int countHB = 0;
        int auxRedP2 = 0;
        string personaje = "Personaje3";

        // Act
        int result = Class1.HabilitatEspecial(ref vidP1, ref vidP2, ref vidP3, ref vidP4, ref vidM, personaje, ataP3, redP2, personajes, ref hb1, ref hb2, ref hb3, ref hb4, ref countHB, ref auxRedP2);

        // Assert

        Assert.AreEqual(5, hb3);


    }

    [TestMethod]
    public void HabilitatEspecial_Personatge4()
    {
        // Arrange
        int vidP1 = 1000;
        int vidP2 = 1200;
        int vidP3 = 800;
        int vidP4 = 900;
        int vidM = 2000;
        int ataP3 = 150;
        int redP2 = 10;
        string[] personajes = { "Personaje1", "Personaje2", "Personaje3", "Personaje4" };
        int hb1 = 0;
        int hb2 = 0;
        int hb3 = 0;
        int hb4 = 0;
        int countHB = 0;
        int auxRedP2 = 0;
        string personaje = "Personaje4";

        // Act
        int result = Class1.HabilitatEspecial(ref vidP1, ref vidP2, ref vidP3, ref vidP4, ref vidM, personaje, ataP3, redP2, personajes, ref hb1, ref hb2, ref hb3, ref hb4, ref countHB, ref auxRedP2);

        // Assert

        Assert.AreEqual(5, hb4);


    }


    [TestMethod]
    public void AtacCritic()
    {
        // Arrange
        int atacCritic = 0;

        // Act
        int result = Class1.AtacCritic(ref atacCritic);

        // Assert
        Assert.AreEqual(atacCritic, result);
        Assert.IsTrue(atacCritic >= 1 && atacCritic <= 100);
    }

    public void FallarAtac()
    {
        // Arrange
        int fallarAtac = 0;

        // Act
        int resultado = Class1.FallarAtac(ref fallarAtac);

        // Assert
        Assert.IsTrue(resultado >= 1 && resultado <= 100);
    }



}
