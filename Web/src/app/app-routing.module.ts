import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { PackageComponent } from './package/package.component';
import { AuthGuard } from './auth/auth-guard';

const routes: Routes = [
  {
    path: 'login',
    component: LoginComponent
  },
  {
    path: 'package',
    component: PackageComponent,
    canActivate: [AuthGuard]
  },
  {
    path: '', redirectTo: 'login', pathMatch:'full'
  },
  {
    path: '**',
    component: LoginComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
