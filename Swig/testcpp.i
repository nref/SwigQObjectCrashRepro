%module(directors="1") TESTCPP

%{

#include "Base.h"
#include "Derived.h"

%}

class QObject
{
public:
  QString objectName() const;
  void setObjectName(const QString &name);
};

%include "std_shared_ptr.i"
%shared_ptr(QObject);
%shared_ptr(TestCpp::Base);
%shared_ptr(TestCpp::Derived);

%include "Base.h"
%include "Derived.h"

