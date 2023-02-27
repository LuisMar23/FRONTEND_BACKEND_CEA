import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from 'src/app/components/login/login.component';
import { RolComponent } from './rol/rol.component';



const routes: Routes = [
  {
    path: '',
    children: [
      { path: 'rol', component: RolComponent },
      // { path: '**', redirectTo: 'rol', pathMatch: 'full' },
      { path: 'login', component: LoginComponent}
    ],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class PruebaRoutingModule { }
