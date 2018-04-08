import { MergeRoutes } from "../../core/utility";
import { NgModule } from "@angular/core";
import { Routes } from "@angular/router";

import { ContainerComponent } from "./components/container.component";
import { ContainerComponent as A11ContainerComponent } from "./moduleA11/components/container.component";
import { ContainerComponent as A12ContainerComponent } from "./moduleA12/components/container.component";

const childrens: Routes = [
    { path: "a11", component: A11ContainerComponent },
    { path: "a12", component: A12ContainerComponent }
];

const routes: Routes = [
  {
    path: "a1",
    component: ContainerComponent,
    children: MergeRoutes([childrens])
  }
];


@NgModule()
export class RoutingModule {

  static get routes(): Routes {
    return routes;
  }
}
