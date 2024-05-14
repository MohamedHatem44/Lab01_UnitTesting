using CarFactoryLibrary;

namespace CarFactoryLibrary_Tests
{
    public class CarStoreTests
    {
        /*-----------------------------------------------------------------*/
        #region Collection
        // No.1
        [Fact]
        public void EmptyList_ListDoesNotContain()
        {
            // Arrange
            CarStore carStore = new CarStore();

            // Act

            // Collection Asserts
            Assert.Empty(carStore.cars);
        }
        /*-----------------------------------------------------------------*/
        // No.2
        [Fact]
        public void AddCars_AddBMW_TwoListContainsSameObjects()
        {
            // Arrange
            CarStore carStore1 = new CarStore();
            CarStore carStore2 = new CarStore();
            BMW bMW = new BMW();

            // Act
            carStore1.AddCar(bMW);
            carStore2.AddCar(bMW);

            // Collection Asserts
            Assert.NotEmpty(carStore1.cars);
            Assert.NotEmpty(carStore2.cars);
            Assert.Equal(carStore1.cars.Count, carStore2.cars.Count);

            Assert.Equal(carStore1.cars, carStore2.cars);

            Assert.Contains<Car>(bMW, carStore1.cars);
            Assert.Contains<Car>(bMW, carStore2.cars);
        }
        /*-----------------------------------------------------------------*/
        // No.3
        [Fact]
        public void AddCars_AddBMW_TwoListContainsDifferentObjects()
        {
            // Arrange
            CarStore carStore1 = new CarStore();
            CarStore carStore2 = new CarStore();

            BMW bMW = new BMW();
            Toyota toyota = new Toyota();

            // Act
            carStore1.AddCar(bMW);
            carStore1.AddCar(toyota);
            carStore2.AddCar(bMW);

            // Collection Asserts
            Assert.NotEmpty(carStore1.cars);
            Assert.NotEmpty(carStore2.cars);
            Assert.NotEqual(carStore1.cars.Count, carStore2.cars.Count);

            Assert.NotEqual(carStore1.cars, carStore2.cars);
        }
        /*-----------------------------------------------------------------*/
        // No.4
        [Fact]
        public void AddCar_AddBMW_ListContainsSingleObject()
        {
            // Arrange
            CarStore carStore = new CarStore();
            BMW bMW = new BMW();

            // Act
            carStore.AddCar(bMW);

            // Collection Asserts
            Assert.Single(carStore.cars);
            Assert.Contains(bMW, carStore.cars);
            Assert.DoesNotContain(carStore.cars, car => car.velocity == 10);
        }
        /*-----------------------------------------------------------------*/
        // No.5
        [Fact]
        public void AddCar_AddToyota_ListContainObject()
        {
            // Arrange
            CarStore carStore = new CarStore();
            Toyota toyota = new Toyota() { drivingMode = DrivingMode.Forward };

            // Act
            carStore.AddCar(toyota);

            // Collection Asserts
            Assert.Contains<Car>(carStore.cars, c => c.drivingMode == DrivingMode.Forward);
        }
        /*-----------------------------------------------------------------*/
        // No.6
        [Fact]
        public void AddCars_AddListOfCars_CarsAddedToStore()
        {
            // Arrange
            CarStore carStore = new CarStore();
            List<Car> cars = new List<Car>
            {
                new BMW(),
                new Toyota(),
            };

            // Act
            carStore.AddCars(cars);

            // Assert
            foreach (var car in cars)
            {
                Assert.Contains(car, carStore.cars);
            }
        }
        #endregion
        /*-----------------------------------------------------------------*/
    }
}
