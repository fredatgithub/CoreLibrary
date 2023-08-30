﻿namespace CoreLibrary.Extensions
{
  public static class File
  {
    public static byte[] ToByteArray(this string imagePath)
    {
      byte[] bytes = System.IO.File.ReadAllBytes(imagePath);
      return bytes;
    }
  }
}
