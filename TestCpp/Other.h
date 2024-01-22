#pragma once
#include <string>
#include <QtCore/QObject.h>

namespace TestCpp
{
  class Other : public QObject
  {
    Q_OBJECT

  public:
    std::string GetName();
  };
}
