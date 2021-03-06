﻿// Copyright 2015 Tachyus Corp.
//
// Licensed under the Apache License, Version 2.0 (the "License"); you
// may not use this file except in compliance with the License. You may
// obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or
// implied. See the License for the specific language governing
// permissions and limitations under the License.

namespace Gluon

open System
open System.Collections.Generic
open System.Threading.Tasks

/// Formalizes OWIN Application Function.
type AppFunc = Func<IDictionary<string, obj>, Task>

/// Formalizes OWIN Middleware Function.
type MidFunc = Func<AppFunc, AppFunc>

/// This gets passed into methods automatically.
[<Sealed>]
type Context(environment: IDictionary<string, obj>) =

    /// The OWIN execution context.
    member __.Environment = environment
