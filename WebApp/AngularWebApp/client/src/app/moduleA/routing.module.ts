import { Utility } from "../core/utility";
import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";

import { ContainerComponent } from "./components/container.component";
import { RoutingModule as A1RoutingModule } from "./moduleA1/routing.module";

const routes: Routes = [
  {
    path: "a",
    component: ContainerComponent,
    children: Utility.mergeRoutes([A1RoutingModule.routes])
  }
];


@NgModule({
    imports: [
        RouterModule.forChild(routes)
    ]
})
export class RoutingModule { }
