import { Routes } from "@angular/router";

export class Utility {

  static mergeRoutes(routesMap: Routes[]) {

    let mergedRoutes: Routes = [];

    for (let routes of routesMap) {
      mergedRoutes = mergedRoutes.concat(routes);
    }

    return mergedRoutes;
  }

}