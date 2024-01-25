#pragma once
#include <memory>
#include <QtCore/qobject.h>
#include <cstdio>

namespace TestCpp
{
  class Base : public QObject
  {
#ifndef SWIG
    Q_OBJECT
#endif
  };
}

