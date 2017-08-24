﻿import { NgModule } from "@angular/core";

import { RoutingModule } from "./routing.module";
import { ContainerComponent } from "./components/container.component";
import { ListComponent } from "./components/list.component";

@NgModule({
    declarations: [
        ContainerComponent,
        ListComponent
    ],
    imports: [
        RoutingModule
    ]
})
export class Module { }
