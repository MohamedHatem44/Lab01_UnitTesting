using CarFactoryLibrary;

namespace CarFactoryLibrary_Tests
{
    public class ToyotaTests
    {
        /*-----------------------------------------------------------------*/
        #region Boolean Assert
        // Test IsStopped Method
        // Case 1
        [Fact]
        public void IsStopped_Velocity0_true()
        {
            // Arrange
            Toyota toyota = new Toyota();
            toyota.velocity = 0;

            // Act
            bool actualResult = toyota.IsStopped();

            // Boolean Assert
            Assert.True(actualResult);
        }
        /*-----------------------------------------------------------------*/
        // Case 2 
        [Fact]
        public void IsStopped_Velocity10_false()
        {
            // Arrange
            Toyota toyota = new Toyota();
            toyota.velocity = 10;

            // Act
            bool actualResult = toyota.IsStopped();

            // Boolean Assert
            Assert.False(actualResult);
        }
        /*-----------------------------------------------------------------*/
        // Test Over100KMPerHour Method
        // Case 1
        [Fact]
        public void Over100KMPerHour_Velocity110_true()
        {
            // Arrange
            Toyota toyota = new Toyota();
            toyota.velocity = 110;

            // Act
            bool actualResult = toyota.Over100KMPerHour();

            // Boolean Assert
            Assert.True(actualResult);
        }
        /*-----------------------------------------------------------------*/
        // Case 2 
        [Fact]
        public void Over100KMPerHour_Velocity90_false()
        {
            // Arrange
            Toyota toyota = new Toyota();
            toyota.velocity = 90;

            // Act
            bool actualResult = toyota.Over100KMPerHour();

            // Boolean Assert
            Assert.False(actualResult);
        }
        /*-----------------------------------------------------------------*/
        // Case 3
        [Fact]
        public void Over100KMPerHour_Velocity100_false()
        {
            // Arrange
            Toyota toyota = new Toyota();
            toyota.velocity = 100;

            // Act
            bool actualResult = toyota.Over100KMPerHour();

            // Boolean Assert
            Assert.False(actualResult);
        }
        #endregion
        /*-----------------------------------------------------------------*/
        #region Numeric Assert
        // No.1
        [Fact]
        public void IncreaseVelocity_velocity30Add40_Velocity70()
        {
            // Arrange
            Toyota toyota = new Toyota() { velocity = 30 };
            double AddedVelocity = 40;

            // Act
            toyota.IncreaseVelocity(AddedVelocity);

            // Equality Assert
            Assert.Equal(70, toyota.velocity);
        }
        /*-----------------------------------------------------------------*/
        [Fact]
        // No.2
        public void TimeToCoverDistance_velocity70Distance70_Time1()
        {
            // Arrange
            Toyota toyota = new Toyota() { velocity = 70 };
            double distance = 70;

            // Act
            double time =  toyota.TimeToCoverDistance(distance);

            // Equality Assert
            Assert.Equal(1, time);
        }
        /*-----------------------------------------------------------------*/
        [Fact]
        // No.3
        public void Accelerate_velocity30_Velocity35()
        {
            // Arrange
            Toyota toyota = new Toyota() { velocity = 30 };

            // Act
            toyota.Accelerate();

            // Equality Assert
            Assert.Equal(35, toyota.velocity);
        }
        /*-----------------------------------------------------------------*/
        [Fact]
        // No.4
        public void Accelerate_velocity30_VelocityRange30To40()
        {
            // Arrange
            Toyota toyota = new Toyota() { velocity = 30 };

            // Act
            toyota.Accelerate();

            // Equality Assert
            Assert.InRange(toyota.velocity, 30, 40);
        }
        /*-----------------------------------------------------------------*/
        [Fact]
        // No.5
        public void Stop_velocity30_Velocity0()
        {
            // Arrange
            Toyota toyota = new Toyota() { velocity = 30 };

            // Act
            toyota.Stop();

            // Equality Assert
            Assert.Equal(0, toyota.velocity);
            Assert.NotEqual(30, toyota.velocity);
        }
        /*-----------------------------------------------------------------*/
        [Fact]
        // No.6
        public void CalcDistance_velocity100Time2_Distance200()
        {
            // Arrange
            Toyota toyota = new Toyota() { velocity = 100 };
            double time = 2;

            // Act
            var distance = toyota.ClacDistance(toyota.velocity, time);

            // Equality Assert
            Assert.Equal(200, distance);
        }
        #endregion
        /*-----------------------------------------------------------------*/
        #region String Assert
        [Fact]
        // No.1
        public void GetDirection_DirectionBackward_Backward()
        {
            // Arrange
            Toyota toyota = new Toyota() { drivingMode = DrivingMode.Backward };

            // Act
            string result = toyota.GetDirection();

            // String Assert
            Assert.Equal("Backward", result);
            Assert.NotEqual("Forward", result);
        }
        /*-----------------------------------------------------------------*/
        // No.2
        [Fact]
        public void GetDirection_DirectionForward_Forward()
        {
            // Arrange
            Toyota toyota = new Toyota() { drivingMode = DrivingMode.Forward };

            // Act
            string result = toyota.GetDirection();

            // String Assert
            Assert.StartsWith("For", result);
            Assert.EndsWith("rd", result);

            Assert.Contains("w", result);
            Assert.DoesNotContain("yb", result);

            Assert.Matches("F[a-z]{6}", result);
            Assert.DoesNotMatch("F[a-z]{8}", result);
            Assert.DoesNotContain("8", result);
        }
        /*-----------------------------------------------------------------*/
        // No.3
        [Fact]
        public void GetCarType_TypeToyota_Toyota()
        {
            // Arrange
            Toyota toyota = new Toyota() { carTypes = CarTypes.Toyota };

            // Act
            string result = toyota.GetCarType();

            // String Assert
            Assert.Equal("Toyota", result);
            Assert.NotEqual("BMW", result);

            Assert.StartsWith("To", result);
            Assert.EndsWith("a", result);

            Assert.Contains("y", result);
            Assert.DoesNotContain("sxw", result);

            Assert.Matches("T[a-z]{5}", result);
            Assert.DoesNotMatch("S[a-z]{8}", result);
        }
        #endregion
        /*-----------------------------------------------------------------*/
    }
}
