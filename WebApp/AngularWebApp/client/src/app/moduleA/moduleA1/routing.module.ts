import { Utility } from "../../core/utility";
import { NgModule } from "@angular/core";
import { Routes } from "@angular/router";

import { ContainerComponent } from "./components/container.component";
import { ContainerComponent as A11ContainerComponent } from "./moduleA11/components/container.component";

const childrens1: Routes = [
  { path: "a11", component: A11ContainerComponent }
];

const routes: Routes = [
  {
    path: "a1",
    component: ContainerComponent,
    children: Utility.mergeRoutes([childrens1])
  }
];


@NgModule()
export class RoutingModule {

  static get routes(): Routes {
    return routes;
  }

}
