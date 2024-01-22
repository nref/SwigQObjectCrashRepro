#pragma once
#include <memory>
#include "Other.h"

namespace TestCpp
{
  class Base
  {
  public:
    std::shared_ptr<Other> GetSharedPtr();
  };
}

