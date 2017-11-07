import { NgModule } from "@angular/core";
import { RouterModule } from "@angular/router";

import { RoutingModule } from "./routing.module";
import { DetailComponent } from "./components/detail.component";
import { ListComponent } from "./components/list.component";

@NgModule({
    declarations: [
        DetailComponent,
        ListComponent
    ],
    imports: [
        RoutingModule,
        RouterModule
    ]
})
export class Module { }
