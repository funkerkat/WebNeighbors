﻿using System;

namespace WebNeighbors.Models
{
  public class Person
  {
    public int Id { get; set; }

    public string PersonName { get; set; }

    public string ServiceName { get; set; }

    public string ServiceDescription{ get; set; }

    public string CoordinateX { get; set; }

    public string CoordinateY { get; set; }

    //  public DateTime PostingDate { get; set; }
  }
}