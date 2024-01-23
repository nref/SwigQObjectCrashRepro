#include "pch.h"
#include "Base.h"

using namespace TestCpp;

std::shared_ptr<QObject> TestCpp::Base::GetSharedPtr()
{
  return std::shared_ptr<QObject>(this);
}

std::shared_ptr<Base> TestCpp::Base::GetSharedPtr2()
{
  return std::shared_ptr<Base>(this);
}
