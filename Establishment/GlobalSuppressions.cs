// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Code Analysis results, point to "Suppress Message", and click 
// "In Suppression File".
// You do not need to add suppressions to this file manually.

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Establishment.Models")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Establishment.Exceptions")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", Justification = "Establish.ForObject is performing the validation", Scope = "member", Target = "Establishment.BaseEstablisher`1.#Satisfies`1(System.Action`1<!0>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", Justification = "Establish.ForObject is performing the validation", Scope = "member", Target = "Establishment.BaseEstablisher`1.#Satisfies`1(System.Func`2<!0,System.Boolean>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Establishment.BaseEstablisher`1.#Satisfies`1(System.Action`1<!0>)", Justification = "The caught exception is added as an inner exception to a new (optionally) thrown exception")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Establishment.BaseEstablisher`1.#Satisfies`1(System.Func`2<!0,System.Boolean>)", Justification = "The caught exception is added as an inner exception to a new (optionally) thrown exception")]
