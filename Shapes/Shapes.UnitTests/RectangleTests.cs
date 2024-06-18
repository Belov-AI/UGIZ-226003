
namespace Shapes.UnitTests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ConstructorTest()
        {
            var point = new Point(1, 2);
            var rectangle = new Rectangle(point, 5, 4);

            Assert.That(rectangle.Width, Is.EqualTo(5));
            Assert.That(rectangle.Height, Is.EqualTo(4));
            Assert.That(rectangle.LetTop.X, Is.EqualTo(1));
            Assert.That(rectangle.LetTop.Y, Is.EqualTo(2));
        }

        [TestCase(5,4)]
        [TestCase(1.5,2.7)]
        [TestCase(125, 100)]
        public void AreaTest(double width, double height)
        {
            var point = new Point(1, 2);

            var rectangle = new Rectangle(point, width, height);

            Assert.That(rectangle.Area, Is.EqualTo(width * height));
        }
    }
}