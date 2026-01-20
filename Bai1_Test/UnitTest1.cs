using LAB4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Microsoft.VisualStudio.TestTools.UnitTesting; 
using LAB4; // Khai báo namespace của project cần test 

namespace Bai1_Test
{
  
    [TestClass] // Đánh dấu lớp kiểm thử 
    public class UnitTest1
    {
        
        [TestMethod] // Test trường hợp số mũ bằng 0 
        public void TestPower_NIsZero()
        {
            double expected = 1.0; 
            double actual = Bai1.Power(5.5, 0);
            Assert.AreEqual(expected, actual, 0.001); // Sử dụng delta cho số thực [cite: 541]
        }

        
        [TestMethod] // Test trường hợp số mũ dương 
        public void TestPower_NIsPositive()
        {
            double expected = 8.0;
            double actual = Bai1.Power(2.0, 3);
             Assert.AreEqual(expected, actual, 0.001); 
        }

       
        [TestMethod] // Test trường hợp số mũ âm 
        public void TestPower_NIsNegative()
        {
            double expected = 0.25; // 2^-2 = 1/4
            double actual = Bai1.Power(2.0, -2);
             Assert.AreEqual(expected, actual, 0.001);
        }
    }
}