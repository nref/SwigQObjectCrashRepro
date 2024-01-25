#pragma once
#include <string>
#include "Base.h"
#include <cstdio>

namespace TestCpp
{
  class Derived : public Base
  {
  public:
    virtual ~Derived() {
      printf("~Derived()");
      fflush(stdout);
    }
  };
}
