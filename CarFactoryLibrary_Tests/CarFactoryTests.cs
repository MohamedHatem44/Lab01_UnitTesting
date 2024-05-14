using CarFactoryLibrary;

namespace CarFactoryLibrary_Tests
{
    public class CarFactoryTests
    {
        /*-----------------------------------------------------------------*/
        #region Reference Assert
        // No.1
        [Fact]
        public void AskForRefrence_same()
        {
            //Arrange
            Toyota toyota1 = new();
            Toyota toyota2 = new();

            //Act
            Car car = toyota1.GetMyCar();

            //Refrence Assert
            Assert.Same(car, toyota1);
            Assert.NotSame(car, toyota2);
            Assert.NotNull(toyota1);
            Assert.NotNull(toyota2);
            Assert.NotNull(car);
        }
        /*-----------------------------------------------------------------*/
        // No.2
        [Fact]
        public void NewCar_AskForAudi_null()
        {
            // Arrange

            // Act
            Car? result = CarFactory.NewCar(CarTypes.Audi);

            // Reference Asssert
            Assert.Null(result);
        }
        /*-----------------------------------------------------------------*/
        // No.3
        [Fact]
        public void NewCar_AskForToyota_toyotaObject()
        {
            // Arrange
            Toyota toyota = new Toyota();

            // Act
            Car? result = CarFactory.NewCar(CarTypes.Toyota);

            // Reference Assert
            Assert.NotNull(result);
            Assert.NotSame(toyota, result);

            // Equality Assert 
            Assert.Equal(toyota, result);

            Assert.NotNull(toyota);
            Assert.NotNull(result);
        }
        #endregion
        /*-----------------------------------------------------------------*/
        #region Type Assert
        // No.1
        [Fact]
        public void NewCar_TestForBMW_BMWObject()
        {
            //Arrange

            //Act
            Car? car = CarFactory.NewCar(CarTypes.BMW);
            Car? car2 = CarFactory.NewCar(CarTypes.BMW);

            //Type Assert
            Assert.IsType<BMW>(car);
            Assert.IsNotType<Toyota>(car);
            Assert.IsAssignableFrom<Car>(car);
            Assert.IsAssignableFrom<Car>(car2);
            Assert.NotNull(car);
        }
        /*-----------------------------------------------------------------*/
        // No.2
        [Fact]
        public void NewCar_TestForToyota_ToyotaObject()
        {
            //Arrange

            //Act
            Car? car = CarFactory.NewCar(CarTypes.Toyota);

            //Type Assert
            Assert.IsType<Toyota>(car);
            Assert.IsNotType<BMW>(car);
            Assert.IsAssignableFrom<Car>(car);
            Assert.NotNull(car);
        }
        #endregion
        /*-----------------------------------------------------------------*/
        #region Exception
        [Fact]
        public void NewCar_AskForHonda_Exception()
        {
            // Arrange

            // Exception Assert
            Assert.Throws<NotImplementedException>(() =>
            {
                // Act
                Car? result = CarFactory.NewCar(CarTypes.Honda);
            });
            Assert.ThrowsAny<Exception>(() =>
            {
                // Act
                Car? result = CarFactory.NewCar(CarTypes.Honda);
            });
        }
        #endregion
        /*-----------------------------------------------------------------*/
    }
}
