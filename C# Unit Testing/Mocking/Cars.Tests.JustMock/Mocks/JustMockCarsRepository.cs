namespace Cars.Tests.JustMock.Mocks
{
    using System.Linq;

    using Cars.Contracts;
    using Cars.Models;

    using Telerik.JustMock;

    public class JustMockCarsRepository : CarRepositoryMock, ICarsRepositoryMock
    {
        protected override void ArrangeCarsRepositoryMock()
        {
            this.CarsData = Mock.Create<ICarsRepository>();
            Mock.Arrange(() => this.CarsData.Add(Arg.IsAny<Car>())).DoNothing();
            Mock.Arrange(() => this.CarsData.All()).Returns(this.FakeCarCollection);
            Mock.Arrange(() => this.CarsData.Search(Arg.NullOrEmpty)).Returns(this.FakeCarCollection);
            Mock.Arrange(() => this.CarsData.Search(Arg.Matches<string>(s => s == "Opel"))).Returns(this.FakeCarCollection.Where(c => c.Make == "Opel").ToList());

            Mock.Arrange(() => this.CarsData.GetById(Arg.IsInRange<int>(5, 50, RangeKind.Inclusive))).Returns(() => null);
            Mock.Arrange(() => this.CarsData.GetById(Arg.IsInRange<int>(1, 5, RangeKind.Inclusive))).Returns(this.FakeCarCollection.FirstOrDefault());
            Mock.Arrange(() => this.CarsData.SortedByMake()).Returns(this.FakeCarCollection.OrderBy(c => c.Make).ToList());
            Mock.Arrange(() => this.CarsData.SortedByYear()).Returns(this.FakeCarCollection.OrderByDescending(c => c.Year).ToList());
        }
    }
}