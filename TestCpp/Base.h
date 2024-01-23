#pragma once
#include <memory>
#include <QtCore/qobject.h>

namespace TestCpp
{
  class Base : public QObject
  {
#ifndef SWIG
    Q_OBJECT
#endif

  public:
    std::shared_ptr<QObject> GetSharedPtr();
    std::shared_ptr<Base> GetSharedPtr2();
    std::string GetName() { return "Money!"; }
  };
}

