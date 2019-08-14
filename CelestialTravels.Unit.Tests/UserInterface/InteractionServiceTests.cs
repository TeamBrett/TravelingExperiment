using CelestialTravels0_1.UserInterface;
using Moq;
using Xunit;

namespace CelestialTravels.Unit.Tests.Verifications
{
    public class InteractionServiceTests
    {
        private readonly Mock<IInputOutput> mockInputOutput;

        public InteractionServiceTests() {
            this.mockInputOutput = new Mock<IInputOutput>();
        }

        [Fact]
        public void GetUserInputForNumberedOptionMenu_InvalidInput_PromptsForValidInput() {
            var service = this.GetInteractionService();

            service.GetUserInputForNumberedOptionMenu("one", 4);

            this.mockInputOutput.Verify(x => x.WriteLine("Input is not valid, try entering an integer"));
        }

        [Fact]
        public void GetUserInputForNumberedOptionMenu_InvalidInput_GetNewValue() {
            var service = this.GetInteractionService();

            service.GetUserInputForNumberedOptionMenu("one", 4);

            // bf: this test will fail, but the function is actually stuck in an infinite loop that prevents it from passing.
            this.mockInputOutput.Verify(x => x.GetStringInput());
        }

        [Fact]
        public void GetUserInputForNumberedOptionMenu_ValidInput_ReturnsNumber() {
            var service = this.GetInteractionService();

            var num = service.GetUserInputForNumberedOptionMenu(4.ToString(), 5);

            Assert.Equal(4, num);
        }

        private InteractionService GetInteractionService() {
            return new InteractionService(this.mockInputOutput.Object);
        }
    }
}
