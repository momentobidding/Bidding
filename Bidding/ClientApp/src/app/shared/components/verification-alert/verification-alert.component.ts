import { Component, OnInit } from "@angular/core";

// internal
import { AuthService } from "ClientApp/src/app/core/services/auth/auth.service";

@Component({
  selector: "app-verification-alert",
  templateUrl: "./verification-alert.component.html",
  styleUrls: ["./verification-alert.component.scss"],
})
export class VerificationAlertComponent implements OnInit {
  emailVerified: boolean;
  isLoggedIn: boolean;

  constructor(private authService: AuthService) {}

  ngOnInit(): void {
    this.isLoggedIn = this.authService.userDetails?.IsAuthenticated;
    this.emailVerified = this.authService.userDetails?.IsEmailVerified;
  }
}
