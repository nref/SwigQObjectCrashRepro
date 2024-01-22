#include "pch.h"
#include "Base.h"

using namespace TestCpp;

std::shared_ptr<Other> TestCpp::Base::GetSharedPtr()
{
  return std::make_shared<Other>();
}

