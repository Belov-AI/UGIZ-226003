namespace Shapes.UnitTests
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void AreaTest()
        {
            var point = new Point(3, 5);
            var circle = new Circle(point, 2.7489);

            Assert.That(circle.Area, Is.EqualTo(23.7392916085).Within(1e-8));
        }

        [Test] 
        public void RadiusExeptionTest()
        {
            var point = new Point(3, 5);

            //Assert.That(() => new Circle(point,-1), Throws.ArgumentException);

            var ex = Assert.Throws<ArgumentException>(() => new Circle(point, -1));
            Assert.That(ex.Message, Is.EqualTo("Радиус должен быть положительным"));
        }
    }
}
