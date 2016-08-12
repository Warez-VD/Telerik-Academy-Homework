namespace Cars.Tests.JustMock
{
    using System;
    using System.Collections.Generic;
    
    using NUnit.Framework;

    using Cars.Contracts;
    using Cars.Tests.JustMock.Mocks;
    using Cars.Controllers;
    using Cars.Models;

    [TestFixture]
    [Category("CarsControllerTests")]
    public class CarsControllerTests
    {
        private readonly ICarsRepository carsData;
        private CarsController controller;

        public CarsControllerTests()
            : this(new JustMockCarsRepository())
        // : this(new MoqCarsRepository())
        {
        }

        private CarsControllerTests(ICarsRepositoryMock carsDataMock)
        {
            this.carsData = carsDataMock.CarsData;
        }

        [OneTimeSetUp]
        public void CreateController()
        {
            this.controller = new CarsController(this.carsData);
        }

        [Test]
        public void IndexShouldReturnAllCars()
        {
            var model = (ICollection<Car>)this.GetModel(() => this.controller.Index());

            Assert.AreEqual(4, model.Count);
        }

        [Test]
        public void ConstructorWhenEmptyShouldNotBeNull()
        {
            var carController = new CarsController();

            Assert.IsNotNull(carController);
        }

        [Test]
        public void AddingCar_ShouldThrowArgumentNullException_IfCarIsNull()
        {
            Assert.Catch<ArgumentNullException>(() => this.GetModel(() => this.controller.Add(null)));
        }

        [Test]
        public void AddingCar_ShouldThrowArgumentNullException_IfCarMakeIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = null,
                Model = "330d",
                Year = 2014
            };

            Assert.Catch<ArgumentNullException>(() => this.GetModel(() => this.controller.Add(car)));
        }

        [Test]
        public void AddingCar_ShouldThrowArgumentNullException_IfCarModelIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = null,
                Year = 2014
            };
            
            Assert.Catch<ArgumentNullException>(() => this.GetModel(() => this.controller.Add(car)));
        }

        [Test]
        public void AddingCarShouldReturnADetail()
        {
            var car = new Car
            {
                Id = 1,
                Make = "Audi",
                Model = "A5",
                Year = 2005
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));

            Assert.AreEqual(1, model.Id);
            Assert.AreEqual("Audi", model.Make);
            Assert.AreEqual("A5", model.Model);
            Assert.AreEqual(2005, model.Year);
        }

        [Test]
        public void SearchingByNullOrEmptyConditionShouldReturnAllCars()
        {
            var model = (ICollection<Car>)this.GetModel(() => this.controller.Search(null));

            Assert.AreEqual(4, model.Count);
        }
        
        [Test]
        public void Searching_IfConditionEqualsMakeOfCarInList_ShouldReturnAllCarsWithThatMake()
        {
            var model = (ICollection<Car>)this.GetModel(() => this.controller.Search("Opel"));

            Assert.AreEqual(1, model.Count);
        }

        [Test]
        public void Sort_IfParameterIsNullShouldThrowArgumentException()
        {
            Assert.Catch<ArgumentException>(() => this.GetModel(() => this.controller.Sort("Nothing")));
        }

        [Test]
        public void Sort_IfParameterEqualsCasemake_ShouldReturnSortedCarsByMake()
        {
            var model = (IList<Car>)this.GetModel(() => this.controller.Sort("make"));

            Assert.AreEqual("Audi", model[0].Make);
        }

        [Test]
        public void Sort_IfParameterEqualsCaseyear_ShouldReturnSortedCarsByYear()
        {
            var model = (IList<Car>)this.GetModel(() => this.controller.Sort("year"));

            Assert.AreEqual(2010, model[0].Year);
        }

        [Test]
        public void Detail_WhenValidIdIsProvided_ShouldReturnCar()
        {
            var model = (Car)this.GetModel(() => this.controller.Details(1));

            Assert.AreEqual("Audi", model.Make);
        }

        [Test]
        public void Detail_WhenInvalidIdIsProvided_ShouldThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => this.GetModel(() => this.controller.Details(7)));
        }

        private object GetModel(Func<IView> funcView)
        {
            var view = funcView();
            return view.Model;
        }
    }
}