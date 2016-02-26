// Write a function called checkCoupon to verify that a coupon is valid and not expired. If the coupon is good, return true. Otherwise, return false.
// A coupon expires at the END of the expiration date.  All dates will be passed in as strings in this format: "June 15, 2014"
// Assert.AreEqual(true, Kata.CheckCoupon("123","123","September 5, 2014","October 1, 2014"));

using System;

public static class Kata
{
  public static bool CheckCoupon(string enteredCode, string correctCode, string currentDate, string expirationDate)
  {
    var today = DateTime.Parse(currentDate);
    var expiry = DateTime.Parse(expirationDate).AddDays(1);
    return enteredCode == correctCode && expiry >= today;
  }
}
